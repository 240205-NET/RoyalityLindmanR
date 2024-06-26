import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AppComponent } from './app.component';
import { CharacterComponent } from './character/character.component';
import { NavbarComponent } from './navbar/navbar.component';
import { VideoComponent } from './video/video.component';
import { RandomCharacterComponent } from './random-character/random-character.component';


export const routes: Routes = [
    {
        path: '',
        component: HomeComponent,
    },
    {
        path: 'character',
        component: CharacterComponent,
    },
    {
        path: 'video',
        component: VideoComponent,
    },
    {
        path: 'random',
        component: RandomCharacterComponent
    }
    
];

