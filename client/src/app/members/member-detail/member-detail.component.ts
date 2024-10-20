import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Member } from 'src/app/_models/member';
import 'hammerjs';
import { SharedModule } from 'src/app/_modules/shared.module';
import { CommonModule } from '@angular/common';
import { MemberMessagesComponent } from "../member-messages/member-messages.component";
import { TabDirective, TabsetComponent } from 'ngx-bootstrap/tabs';
import { Message } from 'src/app/_models/message';
import { MessageService } from 'src/app/_services/message.service';
import { PresenceService } from 'src/app/_services/presence.service';
import { AccountService } from 'src/app/_services/account.service';
import { User } from 'src/app/_models/user';
import { take } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { MembersService } from 'src/app/_services/members.service';




@Component({
    selector: 'app-member-detail',
    templateUrl: './member-detail.component.html',
    styleUrls: ['./member-detail.component.css'],
    standalone: true,
    imports: [CommonModule, SharedModule, MemberMessagesComponent]
})
export class MemberDetailComponent implements OnInit, OnDestroy {
  @ViewChild('memberTabs', {static: true}) memberTabs: TabsetComponent;
  member: Member;
  // galleryImages: GalleryItem[] = [];
  activeTab: TabDirective;
  messages: Message[] = [];
  user: User;


  constructor(
    public presence: PresenceService, 
    private messageService: MessageService,
    private route: ActivatedRoute,
    private accountService: AccountService,
    private router: Router,
    private membersService: MembersService,
    private toastr: ToastrService ) {
      this.accountService.currentUser$.pipe(take(1)).subscribe(user => this.user = user);
      this.router.routeReuseStrategy.shouldReuseRoute = () => false;
    }

    ngOnInit() {
      this.route.data.subscribe(data => {
        this.member = data['member'];
      }
    );
    
    this.route.queryParams.subscribe(params => {
      params['tab'] ? this.selectTab(params['tab']) : this.selectTab(0);
    });
    
    // this.galleryImages = this.getImages();
  }
  

      
  // getImages(): GalleryItem[] {
  //   const images = [];
  //   for (const photo of this.member.photos) {
  //     images.push(new ImageItem({ src: photo?.url, thumb: photo?.url}));
  //   }
  //   return images;
  // }


  loadMessages() {
    this.messageService.getMessageThread(this.member.username).subscribe(messages => {
      this.messages = messages;
    });
  }

  selectTab(tabId: number) {
    this.memberTabs.tabs[tabId].active = true;
  }

  onTabActivated(data: TabDirective) {
    this.activeTab = data;
    if (this.activeTab.heading === 'Messages' && this.messages.length === 0) {
      this.messageService.createHubConnection(this.user, this.member.username);
    }
    else {
      this.messageService.stopHubConnection();
    }
  }

  
  addLike(member: Member) {
    this.membersService.addLike(member.username).subscribe(() => {
      this.toastr.success('You have liked ' + member.knownAs);
    });
  }

  ngOnDestroy(): void {
    this.messageService.stopHubConnection();

  }

}
