import React, { useRef, useState } from "react";


//class Details extends React.Component{

async function Details() {
  
  const baseURL = "https://localhost:44308/api";

  const get_id = useRef(null);
  const get_title = useRef(null);

  const [getResult, setGetResult] = useState(null);

  const fortmatResponse = (res) => {
    return JSON.stringify(res, null, 2);
  }
  const id = get_id.current.value;

  if (id) {
    try {
      const res = await fetch(`${baseURL}/people/${id}`);

      if (!res.ok) {
        const message = `An error has occured: ${res.status} - ${res.statusText}`;
        throw new Error(message);
      }

      const data = await res.json();

      const result = {
        data: data,
        status: res.status,
        statusText: res.statusText,
        headers: {
          "Content-Type": res.headers.get("Content-Type"),
          "Content-Length": res.headers.get("Content-Length"),
        },
      };

      setGetResult(fortmatResponse(result));
    } catch (err) {
      setGetResult(err.message);
    }
  }

  return (
    <div className="card">
      <div className="card-header">React Fetch GET - BezKoder.com</div>
      <div className="card-body">
        <div className="input-group input-group-sm">
        
          <input type="text" ref={get_id} className="form-control ml-2" placeholder="Id" />
          <div className="input-group-append">
            <button className="btn btn-sm btn-primary" onClick={Details}>Get by Id</button>
            
          </div>

           </div>   
        
        { getResult && <div className="alert alert-secondary mt-2" role="alert"><pre>{getResult}</pre></div> }
      </div>
    </div>
  );
}

//}
export default Details;