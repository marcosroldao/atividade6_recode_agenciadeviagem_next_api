import '@/styles/globals.css'
import Navbar from '@/components/NavBar.js';
import Footer from '@/components/Footer';

export default function App({ Component, pageProps }) {
  return (

    <div>
      <Navbar/>
      <Component {...pageProps} />
 
   
    </div>
    
  );

}