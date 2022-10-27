import React, { Component, useState, useEffect } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';


export function personDetails(id){
    axios.get(`https://localhost:44308/api/details/${id}`)
    .then(res =>{
      console.log(res);
      console.log(res.data);
    })
    return (
        <div>
          console.log(res.data); 
        </div>
      );
  }