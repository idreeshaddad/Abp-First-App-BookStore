import { NgModule } from '@angular/core';

import { BookRoutingModule } from './book-routing.module';
import { BookComponent } from './book.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    BookComponent
  ],
  imports: [
    SharedModule,
    BookRoutingModule
  ]
})
export class BookModule { }
