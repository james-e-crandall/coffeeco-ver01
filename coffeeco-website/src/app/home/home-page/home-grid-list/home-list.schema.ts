import { z } from 'zod';

export const HomeItemSchema = z.object({
  text: z.string(),
});

export const HomeItemArraySchema = z.array(HomeItemSchema);

export const HomeRowSchema = z.object({
  homeItems: HomeItemArraySchema
});

export const HomeRowArraySchema = z.array(HomeRowSchema);

export const HomeListSchema = z.object({
  cols: z.number(),
  homeRows: HomeRowArraySchema
});

export const HomeListArraySchema = z.array(HomeListSchema);

export type HomeItem = z.infer<typeof HomeItemSchema>;

export type HomeRow = z.infer<typeof HomeRowSchema>;

export type HomeList = z.infer<typeof HomeListSchema>;

