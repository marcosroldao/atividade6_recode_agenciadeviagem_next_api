import 'bootstrap/dist/css/bootstrap.css';
import { useEffect, useState } from "react";
import axios from "axios";
import style from '../styles/Home.module.css';
import Link from 'next/link'; // Importe o Link para criar links de navegação
 
const Home = () => {
  const [clients, setClients] = useState([]);
 
  useEffect(() => {
    // Faça uma chamada GET para a API Spring Boot
    axios
      .get("https://viagemapi.somee.com/api/Usuarios")
      .then((response) => {
        setClients(response.data);
      })
      .catch((error) => {
        console.error("Erro ao buscar a lista de clientes:", error);
      });
  }, []);
 
  return (
    <div>
      <h1 className={style.h1}>Lista de Clientes</h1>
      <table className="table container tabela">
        <thead>
          <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Endereço</th>
            <th>Cep</th>
            <th>Cpf</th>
            <th>E-mail</th>
            <th>Senha</th>
            <th>telefone</th>
            <th>datacadastro</th>
            <th>Ações</th> {/* Adicione uma coluna para as ações de edição e exclusão */}
          </tr>
        </thead>
        {clients.map((element) => (
          <tbody key={element.id}>
            <tr className={style.tabela}>
              <td>{element.id_cliente}</td>
              <td>{element.nomecompleto}</td>
              <td>{element.endereco}</td>
              <td>{element.cep}</td>
              <td>{element.cpf}</td>
              <td>{element.e_mail}</td>
              <td>{element.senha}</td>
              <td>{element.telefone}</td>
              <td>{element.datacadastro}</td>

              

 
            </tr>
          </tbody>
        ))}
      </table>

    </div>

    
  );
};
 
export default Home;