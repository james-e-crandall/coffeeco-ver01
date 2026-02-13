export interface HomeList {
  cols: number;
}

export interface HomeRow {
  items: HomeItem[];
}

export interface HomeItem {
  text: string;
  cols?: number;
}
