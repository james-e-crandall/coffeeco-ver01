import { Injectable } from '@angular/core';
import { HomeItem, HomeList, HomeListArraySchema, HomeListSchema, HomeRow } from './home-list.schema';
import { httpResource, HttpResourceRef } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class HomeService {

  homeItems: HomeItem[] = [
    { text: `It's a great day for coffee` },
    { text: `'Start An order'` },
  ];

  homeRows: HomeRow[] = [
    { homeItems: this.homeItems },
  ];

  homeList: HomeList = { cols: 2, homeRows: this.homeRows };

  // GetHomeListCurrent() : HttpResourceRef<HomeList | undefined> {
  //   console.log('GetHomeListCurrent called');
  //   return httpResource<HomeList>(
  //     () => ({
  //       url: `/uiapi/Home/HomeLists/current`,
  //       headers: {
  //         'x-csrf': '1',
  //       },
  //     }),
  //     { parse: (response: unknown): HomeList => HomeListSchema.parse(response) }
  //   );
  // }

  GetHomeListCurrent() : HttpResourceRef<HomeList | undefined> {
    return httpResource<HomeList>(
      () => ({
        url: `/uiapi/Home/HomeLists/current`,
        headers: {
          'x-csrf': '1',
        },
      }),
      { parse: (response: unknown): HomeList => {
        //return HomeListSchema.parse(response);
        console.log('HomeListSchema.parse called');
        let xzy = HomeListSchema.parse(response);
        console.log('HomeListSchema.parse called 2');
        console.log('xzy: ', xzy.cols, xzy.homeRows.length);
        return xzy;
      } }
    );
  }

  GetHomeListCurrent2() : HttpResourceRef<HomeList | undefined> {
    return httpResource<HomeList>(
      () => ({
        url: `/uiapi/Home/HomeLists/current`,
        headers: {
          'x-csrf': '1',
        },
      }),
      { parse: (response: unknown): HomeList => {
        //return HomeListSchema.parse(response);
        const result = HomeListSchema.safeParse(response);
        if (!result.success) {
          return this.homeList;
        } else {
          return result.data;
        }
      } }
    );
  }

}
