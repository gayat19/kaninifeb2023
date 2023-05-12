import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { FirstComponent } from './first.component';


describe('FirstComponent', () => {
  beforeEach(() => TestBed.configureTestingModule({
    imports: [RouterTestingModule],
    declarations: [FirstComponent]
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(FirstComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

});
