import { Component, OnInit, inject } from '@angular/core';
import { RouterLink, RouterModule, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from '../navbar/navbar.component';
import { HomeComponent } from '../home/home.component';
import { Character } from '../_models/character.model';
import { CharacterService } from '../_services/character.service';
import { NgFor } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';


@Component({
  selector: 'app-character',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent, HomeComponent, HttpClientModule],
  templateUrl: './character.component.html',
  styleUrl: './character.component.css'
})
export class CharacterComponent implements OnInit {

    http = inject(HttpClient);
    characters : any = [];
    

  constructor(private characterService : CharacterService) {}

  ngOnInit(): void {
    this.fetchCharacters();
  }
  fetchCharacters() {
    this.http.get('https://bobsburgers-api.herokuapp.com/characters/').subscribe((data :any) => {
      console.log(data);
      this.characters = data;
    })
  }
 }

