import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ArticlesListComponent } from './articles-list/article-list.component';
import { ArticleDetailsComponent } from './articles-list/article-details/article-details.component';
import { ArticleListService } from './articles-list/article-list.service';
import { AppRoutes } from './app.routes';

@NgModule({
  declarations: [
    AppComponent,
    ArticlesListComponent,
    ArticleDetailsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(AppRoutes)
  ],
  providers: [ArticleListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
