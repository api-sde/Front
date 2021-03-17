import logo from './logo.svg';
import './App.css';
import axios, { AxiosRequestConfig, Method } from 'axios';
//import { saveAs } from 'file-saver';

function App() {
  return (
    <div className="App">
      <p>
        Test:
        <button onClick={download}>Take the file!</button>
        <button onClick={getGithub}>Get Github</button>
        <button onClick={getPreview}>Get Preview</button>
      </p>

      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >

        </a>
      </header>


    </div>
  );
}

function getGithub() {
  axios.get('https://api.github.com/users/mapbox')
  .then(response => {
    console.log(response.data.avatar_url);
    console.log(response.data);
  });
}

function getPreview() {
  axios.get('http://localhost:8080/api/report/download/finance/preview/', {
    headers: 
      {
        'Authorization': 'Bearer nope',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Headers': '*',
        'Access-Control-Allow-Credentials':true,
      } 
    })
  .then(response => {
    console.log(response.status);
    console.log(response.data);
  });
}

function download() {
  
  axios({
    url: 'http://localhost:8080/api/report/download/finance/excel/finance.xlsx',
    method: 'GET',
    responseType: 'blob', // important
    headers: {
      'Authorization': 'Bearer nope',
      'Access-Control-Allow-Origin': '*',
      'Access-Control-Allow-Headers': '*',
      'Access-Control-Allow-Credentials':true,
      'Referrer-Policy': 'unsafe-url'
    }
  }).then((response) => {
    const url = window.URL.createObjectURL(new Blob([response.data]));
    const link = document.createElement('a');
    link.href = url;
    link.setAttribute('download', 'file.xlsx');
    link.setAttribute('noreferrer')
    document.body.appendChild(link);
    link.click();
  });
}

export default App;
