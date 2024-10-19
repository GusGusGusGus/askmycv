import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class FilesService {
  private apiUrl = `${environment.apiUrl}documents`;

  constructor(private http: HttpClient) {}

  // Upload a file
  uploadFile(file: File): Observable<any> {
    const formData: FormData = new FormData();
    formData.append('file', file, file.name);

    return this.http.post(`${this.apiUrl}/upload`, formData);
  }

  // Download a file by name
  downloadFile(fileName: string): Observable<Blob> {
    return this.http.get(`${this.apiUrl}/download/${fileName}`, {
      responseType: 'blob'  // Blob is used for binary file downloads
    });
  }

  // Trigger download in the browser (utility function)
  triggerFileDownload(fileName: string): void {
    this.downloadFile(fileName).subscribe((fileBlob: Blob) => {
      const url = window.URL.createObjectURL(fileBlob);
      const fileLink = document.createElement('a');
      fileLink.href = url;
      fileLink.download = fileName;
      document.body.appendChild(fileLink);
      fileLink.click();
      document.body.removeChild(fileLink);
    });
  }

  // Delete a file by name
  deleteFile(fileName: string): Observable<any> {
    return this.http.delete(`${this.apiUrl}/delete/${fileName}`);
  }

  // Update a file (similar to upload but replaces an existing file)
  updateFile(fileName: string, file: File): Observable<any> {
    const formData: FormData = new FormData();
    formData.append('file', file, file.name);

    return this.http.put(`${this.apiUrl}/update/${fileName}`, formData);
  }

  // List all files for the user
  listAllFiles(): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/list`);
  }
}