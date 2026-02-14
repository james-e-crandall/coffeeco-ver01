import { Injectable } from '@angular/core';
import { HomeItem, HomeList, HomeListArraySchema, HomeListSchema, HomeRow } from './home-list.schema';
import { httpResource, HttpResourceRef } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class HomeService {

  homeItems: HomeItem[] = [
    { text: 'Espresso' },
    { text: 'Cappuccino' },
    { text: 'Latte' },
    { text: 'Americano' },
  ];

  homeRows: HomeRow[] = [
    { homeItems: this.homeItems },
  ];

  homeList: HomeList = { cols: 3, homeRows: this.homeRows };

  GetHomeListCurrent() : HttpResourceRef<HomeList | undefined> {
    return httpResource<HomeList>(
      () => ({
        url: `/uiapi/Home/HomeLists/current`,
        headers: {
          'x-csrf': '1',
        },
      }),
      { parse: (response: unknown): HomeList => HomeListSchema.parse(response) }
    );
  }

}
