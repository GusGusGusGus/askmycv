import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, Input, ViewChild } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Message } from 'src/app/_models/message';
import { SharedModule } from 'src/app/_modules/shared.module';
import { MessageService } from 'src/app/_services/message.service';
import { ParseIntPipe } from 'src/app/pipes/parse-int.pipe';

@Component({
  changeDetection: ChangeDetectionStrategy.OnPush,
  selector: 'app-member-messages',
  standalone: true,
  imports: [CommonModule, SharedModule, FormsModule, ParseIntPipe],
  templateUrl: './member-messages.component.html',
  styleUrl: './member-messages.component.css',
})
export class MemberMessagesComponent {
  @ViewChild('messageForm') messageForm: NgForm;
  @Input() messages: Message[];
  @Input() username: string;
  messageContent: string;
  loading = false;
isAutoPilot: any;

  constructor(public messageService: MessageService) {
  }

  ngOnInit(): void {
  }

  sendMessage() {
    this.loading = true;
    this.messageService.sendMessage(this.username, this.messageContent, this.isAutoPilot).then(() => {
      this.messageForm.reset();
    }).finally(() => this.loading = false); 
  }

}
