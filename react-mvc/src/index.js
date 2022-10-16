import React from 'react';
import ReactDOM from 'react-dom';
import * as ReactDOMClient from 'react-dom/client';

//import { BrowserRouter } from "react-router-dom";
// Bootstrap CSS
//import "bootstrap/dist/css/bootstrap.min.css";
// Bootstrap Bundle JS
//import "bootstrap/dist/js/bootstrap.bundle.min";
import { BrowserRouter } from 'react-router-dom';
import "./App.css";
import App from './App';
import reportWebVitals from './reportWebVitals';

//ReactDOMClient.createRoot(/*...*/);


const root = ReactDOMClient.createRoot(document.getElementById('root'));
//const root = ReactDOM.createRoot(document.getElementById('root'));

ReactDOM.render((
  <BrowserRouter>
    <App />
  </BrowserRouter>
), document.getElementById('root'))
/*
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
*/

//ReactDOM.render(<App />, document.getElementById('root'))

/*
ReactDOM.render(
  <BrowserRouter>
    <App />
  </BrowserRouter>,
  document.getElementById("root")
);
*/
reportWebVitals();
