import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import Menu from './components/Menu';
import CreateIntern from './components/CreateIntern';
import ListIntern from './components/ListInterns';
import Home from './components/Home';
import EditIntern from './components/EditIntrn';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Menu/>
        <Routes>
        <Route path='/' element={<Home/>}/>
          <Route path='create' element={<CreateIntern/>}/>
          <Route path='list' element={<ListIntern/>}/>
          <Route path='edit' element={<EditIntern/>}/>
        </Routes>
   
      </BrowserRouter>
    </div>
  );
}

export default App;
