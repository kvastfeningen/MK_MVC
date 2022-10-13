import React from 'react';
import ReactDOM from 'react-dom';
// Bootstrap CSS
//import "bootstrap/dist/css/bootstrap.min.css";
// Bootstrap Bundle JS
//import "bootstrap/dist/js/bootstrap.bundle.min";

import "./App.css";
import App from './App';
import reportWebVitals from './reportWebVitals';
/*
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);
*/
ReactDOM.render(<App />, document.getElementById('root'))

reportWebVitals();
