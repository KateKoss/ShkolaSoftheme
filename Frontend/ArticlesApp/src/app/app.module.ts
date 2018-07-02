import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ArticlesListComponent } from './articles-list/article-list.component';
import { ArticleDetailsComponent } from './articles-list/article-details/article-details.component';
import { ArticleListService } from './articles-list/article-list.service';

@NgModule({
  declarations: [
    AppComponent,
    ArticlesListComponent,
    ArticleDetailsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule  
  ],
  providers: [ArticleListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
