import { Routes } from '@angular/router';
import { PlaceholderPage } from './placeholder/placeholder-page/placeholder-page';
import { HomePage } from './home/home-page/home-page';

const homePageRoute = {
  path: '',
  component: HomePage,
};



const placeholderPageRoute = {
  path: 'placeholder',
  component: PlaceholderPage,
};

  // Redirect any other URLs that don’t match
  // (also known as a "wildcard" redirect)
const redirectRoute = {
  path: '**',
  redirectTo: '/',
};

export const routes: Routes = [
  homePageRoute,
  placeholderPageRoute,
  redirectRoute
];
