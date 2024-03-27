import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CharacterService {
  private url = "https://bobsburgers-api.herokuapp.com/characters"

  constructor(private http: HttpClient) { }

  getCharacter() {
    return this.http.get<any>(this.url);
  }
}
