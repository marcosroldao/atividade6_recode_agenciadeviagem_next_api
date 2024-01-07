import React from 'react';
import styles from '@/styles/Footer.module.css';

const Footer = () => {
  return (
    <footer>
      <div className={styles.footerContainer}>
        <div className={styles.footerText}>
          <p>
            &copy; Boa viagem é uma marca registrada de boaviagem S.A 
            </p>
          
        </div>
      </div>
    </footer>
  );
};

export default Footer;