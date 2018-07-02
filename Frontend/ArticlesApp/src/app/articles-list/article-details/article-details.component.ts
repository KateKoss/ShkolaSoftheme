import { Component, Input } from '@angular/core';

import { Article } from './article.model'

@Component({
    selector: 'article-details',
    templateUrl: './article-details.component.html',
    styleUrls: ['./article-details.component.css']
})
export class ArticleDetailsComponent{
    @Input()
    article : Article
}

