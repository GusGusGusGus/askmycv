import { Component, ViewEncapsulation } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FilesService } from 'src/app/_services/files.service';

@Component({
  selector: 'app-file-uploader',
  templateUrl: './file-uploader.component.html',
  styleUrl: './file-uploader.component.css',
})
export class FileUploaderComponent {
  fileName: string;
  isCV: boolean;

  constructor(private filesService: FilesService,
    private toastr: ToastrService
  ) {}


  onFileSelected(event: Event) {
    debugger;
    const input = event.target as HTMLInputElement;
    if (input.files && input.files.length > 0) {
      this.fileName = input.files[0].name;
      
     this.handleFileUpload(input.files[0]);
      
    }
  }

  //IMPORTANT: to do, enable multiple file upload. for now, the file will be assumed to be CV
  handleFileUpload(file: File) {
    debugger;

     // Handle file upload logic
     this.filesService.uploadFile(file, true).subscribe({
      next: () => {
        this.toastr.success('File uploaded successfully');
      },
      error: (error) => {
        console.error('File upload failed:', error);
        this.toastr.error('File upload failed');
      }
    });
  }

  onDragOver(event: DragEvent) {
    event.preventDefault();
    event.stopPropagation();
    const element = event.currentTarget as HTMLElement;
    element.classList.add('dragover');
  }

  onDragLeave(event: DragEvent) {
    event.preventDefault();
    event.stopPropagation();
    const element = event.currentTarget as HTMLElement;
    element.classList.remove('dragover');
  }

  onDrop(event: DragEvent) {
    debugger;

    event.preventDefault();
    event.stopPropagation();
    const element = event.currentTarget as HTMLElement;
    element.classList.remove('dragover');

    if (event.dataTransfer && event.dataTransfer.files.length > 0) {
      const file = event.dataTransfer.files[0];
      this.fileName = file.name;

       this.handleFileUpload(file);
    }
  }

}
