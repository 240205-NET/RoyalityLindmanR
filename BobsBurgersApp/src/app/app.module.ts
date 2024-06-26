import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CharacterComponent } from './character/character.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { VideoComponent } from './video/video.component';
import { RandomCharacterComponent } from './random-character/random-character.component';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CharacterComponent,
    HomeComponent,
    NavbarComponent,
    HttpClientModule,
    AppComponent,
    VideoComponent,
    RandomCharacterComponent
  ]
})
export class AppModule { }
