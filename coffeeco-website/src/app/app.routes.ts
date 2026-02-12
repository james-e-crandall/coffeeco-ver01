import { Routes } from '@angular/router';
import { PlaceholderPage } from './placeholder/placeholder-page/placeholder-page';
import { HomePage } from './home/home-page/home-page';
import { GiftPage } from './gift/gift-page/gift-page';
import { MenuPage } from './menu/menu-page/menu-page';
import { RewardsPage } from './rewards/rewards-page/rewards-page';
import { StoreLocatorPage } from './store-locator/store-locator-page/store-locator-page';

export const HomePageRoute = {
  path: '',
  component: HomePage,
};

export const GiftPageRoute = {
  path: 'gift',
  component: GiftPage,
};

export const MenuPageRoute = {
  path: 'menu',
  component: MenuPage,
};


export const RewardsPageRoute = {
  path: 'rewards',
  component: RewardsPage,
};

export const StoreLocatorPageRoute = {
  path: 'store-locator',
  component: StoreLocatorPage,
};

export const placeholderPageRoute = {
  path: 'placeholder',
  component: PlaceholderPage,
};

// Redirect any other URLs that don’t match
// (also known as a "wildcard" redirect)
export const redirectRoute = {
  path: '**',
  redirectTo: '/',
};

export const routes: Routes = [
  HomePageRoute,
  GiftPageRoute,
  MenuPageRoute,
  RewardsPageRoute,
  StoreLocatorPageRoute,
  placeholderPageRoute,
  redirectRoute
];
