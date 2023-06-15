import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {MatListModule} from '@angular/material/list';
import {MatButtonModule} from '@angular/material/button';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatIconModule} from '@angular/material/icon';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TreeComponent } from './components/tree/tree.component';
import { HttpClientModule } from '@angular/common/http';
import { TreeNodeComponent } from './components/tree-node/tree-node.component';

const matModules = [
  MatListModule,
  MatButtonModule,
  MatProgressBarModule,
  MatIconModule
]

@NgModule({
  declarations: [
    AppComponent,
    TreeComponent,
    TreeNodeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    matModules
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
