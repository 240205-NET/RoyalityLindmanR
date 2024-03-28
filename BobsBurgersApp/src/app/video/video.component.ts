import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-video',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './video.component.html',
  styleUrl: './video.component.css'
})
export class VideoComponent {
  constructor(private router:Router) {}

    homeClick() {
      this.router.navigate(['/']);
    }
    characterClick() {
      this.router.navigate(['/character']);
    }
    videoClick() {
      this.router.navigate(['/video']);
    }
    randomClick() {
      this.router.navigate(['random']);
    }
  
}
