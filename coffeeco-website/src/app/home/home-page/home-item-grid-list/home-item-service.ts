import { Injectable } from '@angular/core';
import { HomeItem, HomeList, HomeRow } from './home-item';

@Injectable({
  providedIn: 'root',
})
export class HomeItemService {

  homeItems: HomeItem[] = [
    { text: 'Espresso' , cols: 2 },
    { text: 'Cappuccino', cols: 1 },
    { text: 'Latte', cols: 1 },
    { text: 'Americano', cols: 2 },
  ];

  homeRows: HomeRow[] = [
    { items: this.homeItems },
  ];

  homeList: HomeList = { cols: 3 };

  getHomeItems(): HomeItem[] {
    return this.homeItems;
  }

  getHomeRows(): HomeRow[] {
    return this.homeRows;
  }

  getHomeList(): HomeList {
    return this.homeList;
  }

}
