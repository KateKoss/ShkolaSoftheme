import { Route, Routes } from '@angular/router';

import { ArticlesListComponent } from './articles-list/article-list.component';
import { ArticleDetailsComponent } from './articles-list/article-details/article-details.component';

const indexRoute: Route = {
    path: '',
    redirectTo: '/articles',
    pathMatch: 'full'
};

const fallbackRoute: Route = {
    path: '**',
    redirectTo: '/articles',
    pathMatch: 'full'
};

export const AppRoutes: Routes = [
    {
        path: 'articles',
        component: ArticlesListComponent
    },
    {
        path: 'articles/:id',
        component: ArticleDetailsComponent
    },
    indexRoute,
    fallbackRoute
];