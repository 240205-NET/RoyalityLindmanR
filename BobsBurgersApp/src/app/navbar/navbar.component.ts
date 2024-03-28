import { Component } from '@angular/core';
import { OnInit } from '@angular/core';
import { RouterLink, RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { HomeComponent } from '../home/home.component';
import { CharacterComponent } from '../character/character.component';
import { AppComponent } from '../app.component';
import { Routes } from '@angular/router';
import { routes } from '../app.routes'

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterModule, HomeComponent, CharacterComponent, AppComponent],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  constructor(private router: Router) {}

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
