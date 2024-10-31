using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Helpers;
using API.Intefaces;
using AutoMapper;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Threads;
using Message = API.Entities.Message;

namespace API.Controllers
{
    [Authorize]
    public class MessagesController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly ILLMService _llmService;
        private readonly IUnitOfWork _unitOfWork;
        public MessagesController(
            IUnitOfWork unitOfWork, 
            IMapper mapper,
            ILLMService llmService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _llmService = llmService;
        }

        [HttpPost]
        public async Task<ActionResult<MessageDTO>> CreateMessage(CreateMessageDTO createMessageDTO)
        {
            var username = User.GetUsername();
            if (username == createMessageDTO.RecipientUsername.ToLower())
                return BadRequest("You cannot send messages to yourself");

            var sender = await _unitOfWork.UserRepository.GetUserByUsernameAsync(username);
            var recipient = await _unitOfWork.UserRepository.GetUserByUsernameAsync(createMessageDTO.RecipientUsername);
            if (recipient == null) return NotFound();

            if (createMessageDTO.IsAutopilot)
            {   
                var userId = User.GetUserId();
                // await _llmService.RouteRequestAsync(sender, recipient, createMessageDTO.Content);

            }

            var message = new Message
            {
                Sender = sender,
                Recipient = recipient,
                SenderUsername = sender.UserName,
                RecipientUsername = recipient.UserName,
                Content = createMessageDTO.Content
            };

            _unitOfWork.MessageRepository.AddMessage(message);

            if (await _unitOfWork.Complete()) return Ok(_mapper.Map<MessageDTO>(message));

            return BadRequest("Failed to send message");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessagesForUser([FromQuery] MessageParams messageParams)
        {
            messageParams.Username = User.GetUsername();
            var messages = await _unitOfWork.MessageRepository.GetMessagesForUser(messageParams);

            Response.AddPaginationHeader(messages.CurrentPage, messages.PageSize, messages.TotalCount, messages.TotalPages);

            return messages;
        }

        // /// <summary>
        // /// Get message thread between two users
        // /// </summary>
        // /// <param name="username"> The username of the other user</param>
        // /// <returns></returns>
        // [HttpGet("thread/{username}")]
        // public async Task<ActionResult<IEnumerable<MessageDTO>>> GetMessageThread(string username)
        // {
        //     var currentUsername = User.GetUsername();
        //     return Ok(await _unitOfWork.MessageRepository.GetMessageThread(currentUsername, username));
        // }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMessage(int id)
        {
            var username = User.GetUsername();
            var message = await _unitOfWork.MessageRepository.GetMessage(id);

            if (message.Sender.UserName != username && message.Recipient.UserName != username)
                return Unauthorized();

            if (message.Sender.UserName == username) message.SenderDeleted = true;
            if (message.Recipient.UserName == username) message.RecipientDeleted = true;

            if (message.SenderDeleted && message.RecipientDeleted) _unitOfWork.MessageRepository.DeleteMessage(message);

            if (await _unitOfWork.Complete()) return Ok();

            return BadRequest("Problem deleting the message");
        }

        [HttpPost("testllm")]
        public async Task<ActionResult> TestLLM(CreateMessageDTO createMessageDTO)
        {
            var response = await _llmService.RagAsync(createMessageDTO.Content);
            return Ok($"LLM answer: {response}");
        }
    }
}