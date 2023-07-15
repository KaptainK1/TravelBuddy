import { createReducer, on } from '@ngrx/store';
import { TodoItem } from 'src/app/models/todo-item';
import * as actions from './todo-list.actions';

export const initialState: TodoItem[] = [
    {
        title: "test",
        description:"test description",
        duration: 1,
        isDone: false
    },
    {
        title: "test2",
        description:"test description2",
        duration: 12,
        isDone: false
    }
];

export const todoItemReducer = createReducer(
    initialState,
    on(actions.addItem, (state, {todoItem}) => ({...state, todoItem})),
    on(actions.deleteItem, (state, {index}) => {
        const items = [...state];
        return items.splice(index, 1);
    })
)