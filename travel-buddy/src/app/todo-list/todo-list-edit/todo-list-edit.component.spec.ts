import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoListEditComponent } from './todo-list-edit.component';

describe('TodoListEditComponentComponent', () => {
  let component: TodoListEditComponent;
  let fixture: ComponentFixture<TodoListEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TodoListEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TodoListEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
