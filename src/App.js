import logo from './logo.svg';
import './App.css';
import Random from './components/Random';
import Tag from './components/Tag';

function App() {
  return (
    <div className="App">
        <h1>RANDOM GIF</h1>
        <div className="flex">
          <Random/>
          <Tag/>
        </div>
    </div>
  );
}

export default App;
