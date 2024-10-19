import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { HTTP_INTERCEPTORS, provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavComponent } from './nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { SharedModule } from './_modules/shared.module';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { MemberCardComponent } from './members/member-card/member-card.component';
import { JwtInterceptor } from './_interceptors/jwt.interceptor';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { LoadingInterceptor } from './_interceptors/loading.interceptor';
import { PhotoEditorComponent } from './members/photo-editor/photo-editor.component';
import { TextInputComponent } from './_forms/text-input/text-input.component';
import { DateInputComponent } from './_forms/date-input/date-input.component';
import { HasRoleDirective } from './_directives/has-role.directive';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { UserManagementComponent } from "./admin/user-management/user-management.component";
import { PhotoManagementComponent } from "./admin/photo-management/photo-management.component";
import { RolesModalComponent } from './modals/roles-modal/roles-modal.component';
// import { ParticlesModule } from './particles/particles.module';
import { ResetPasswordComponent } from './reset-password/reset-password.component';
import { ResetPasswordModalComponent } from './modals/reset-password-modal/reset-password-modal.component';
import { TimelineComponent } from './timeline/timeline.component';
import { FileUploaderComponent } from "./members/file-uploader/file-uploader.component";

//DetailsComponent is now a standalone component, so it isn't present in the declarations array of the AppModule anymore. 
@NgModule({ declarations: [
        AppComponent,
        NavComponent,
        HomeComponent,
        RegisterComponent,
        MemberListComponent,
        ListsComponent,
        MessagesComponent,
        TestErrorsComponent,
        NotFoundComponent,
        ServerErrorComponent,
        MemberCardComponent,
        MemberEditComponent,
        PhotoEditorComponent,
        TextInputComponent,
        DateInputComponent,
        HasRoleDirective,
        PhotoManagementComponent,
        UserManagementComponent,
        AdminPanelComponent,
        RolesModalComponent,
        ResetPasswordComponent,
        ResetPasswordModalComponent,
        TimelineComponent,
        FileUploaderComponent
    ],
    bootstrap: [AppComponent], imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    SharedModule
], providers: [
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true },
        provideHttpClient(withInterceptorsFromDi())
    ] })
export class AppModule { }
