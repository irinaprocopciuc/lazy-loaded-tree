import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { TreeModel } from '../models/tree-model';

@Injectable({
  providedIn: 'root',
})
export class NodeService {
  mainUrl = 'http://localhost:5041';

  constructor(private http: HttpClient) {}

  getRootNodes(): Observable<TreeModel[]> {
    const url = this.mainUrl + `/api/tree`;
    return this.http.get<TreeModel[]>(url);
  }

  getChildNodes(nodeId: number): Observable<TreeModel[]> {
    const url = this.mainUrl + `/api/tree/${nodeId}`;
    return this.http.get<TreeModel[]>(url);
  }
}
