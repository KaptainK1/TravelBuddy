import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoListEditComponentComponent } from './todo-list-edit-component.component';

describe('TodoListEditComponentComponent', () => {
  let component: TodoListEditComponentComponent;
  let fixture: ComponentFixture<TodoListEditComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TodoListEditComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TodoListEditComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
