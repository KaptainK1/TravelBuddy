import { createAction, props } from '@ngrx/store';
import { TodoItem } from 'src/app/models/todo-item';

export const addItem = createAction('[Todo List] Add Item', props<{todoItem: TodoItem}>());
export const getItems = createAction('[Todo List] Get Items')
export const deleteItem = createAction('[Todo List] Delete Item', props<{index: number}>());
export const updateItem = createAction('[Todo List] updateItem Item', props<{index: number, updatedItem : TodoItem}>());