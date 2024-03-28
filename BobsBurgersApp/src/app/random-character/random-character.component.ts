import { Component, inject, OnInit } from '@angular/core';
import { RouterLink, Router, RouterModule } from '@angular/router';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Inject } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-random-character',
  standalone: true,
  imports: [CommonModule, RouterModule, HttpClientModule],
  templateUrl: './random-character.component.html',
  styleUrl: './random-character.component.css'
})
export class RandomCharacterComponent implements OnInit{

  http = inject(HttpClient);
  character : any;

  constructor(private router: Router) {}

  createRandom(min: number, max: number) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }

  rand = this.createRandom(1, 496);
  url = "https://bobsburgers-api.herokuapp.com/characters/";

  ngOnInit() :void {
    this.fetchCharacter();
  }

  fetchCharacter() {
    this.http.get(this.url + this.rand).subscribe((data: any) => {
      console.log(data);
      this.character = data;
    })
  }

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
