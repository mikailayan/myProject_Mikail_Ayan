import logo from './logo.svg';
import './App.css';
import Navbar from './Component/Navbar';
import Section from './Component/Section';
import Footer from './Component/Footer';
import Section2 from './Component/Section2';

function App() {
  return (
    <div className="App">
      <Navbar />
      <Section />
      <Section2 />
      <Footer />
    </div>
  );
}

export default App;
