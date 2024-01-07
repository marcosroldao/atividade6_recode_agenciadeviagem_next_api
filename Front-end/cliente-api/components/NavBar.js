import React from 'react';
import Link from 'next/link';
import 'bootstrap/dist/css/bootstrap.min.css';
import '@/styles/Navbar.module.css'


const Navbar = () => {
    return (
        <nav className="navbar navbar-expand-lg" style={{ background: 'white' }}>
            <div className="navbar-logo">
                <img src="images/icone.png" alt="Logo" style={{ height: '100px', width: 'auto', left: '50%' }} />
            </div>
            <div className='d-grid place-items-center'>
                <ul className="navbar-nav ml-auto">
                    <li className="nav-item">
                        <Link href="/">
                            <span  >Usuários</span>
                        </Link>
                    </li>
                    <li className="nav-item">
                        <Link href="/reservas">
                            <span >Reservas</span>
                        </Link>
                    </li>
                    <li className="nav-item">
                        <Link href="/passagem">
                            <span  >Passagem</span>
                        </Link>
                    </li>
                </ul>
            </div>
        </nav>
    );
};

export default Navbar;