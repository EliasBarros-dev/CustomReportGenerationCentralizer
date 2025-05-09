🎯 Nome do Projeto
Centralizador de Geração de Relatórios Personalizados (CGRP)

👔 Situação (como stakeholder)
Na nossa empresa, cada área (Financeiro, Vendas, RH) precisa de relatórios periódicos com formatos e fontes de dados diferentes. Atualmente, os relatórios são gerados manualmente, o que gera retrabalho, erros e atrasos. Queremos automatizar esse processo com um sistema que seja flexível o suficiente para gerar múltiplos tipos de relatórios de forma escalável e com baixo acoplamento, conforme a necessidade de cada setor.

🧩 Proposta de Solução
Um sistema web (pode ser console ou API para o MVP) que permita:
Cadastrar templates de relatórios

Selecionar tipo de relatório e parâmetros

Gerar relatórios dinamicamente com base nas configurações

Armazenar logs de geração

Consultar histórico de relatórios gerados

🛠️ Design Pattern Criacional Aplicado
Use o Abstract Factory para gerar diferentes tipos de relatórios de forma desacoplada

🧪 Critérios Técnicos do Projeto
✅ .NET 8 (ou 7) Web API

✅ Design Pattern: Abstract Factory (obrigatório), opcional usar Singleton ou Builder em conjunto

✅ SQL Server: armazenamento de templates, logs e histórico

✅ DDD: aplicação dividida em camadas (Domain, Application, Infrastructure, API)

✅ Autenticação: JWT ou Basic (simples para MVP)

✅ Injeção de dependência com o Microsoft.Extensions.DependencyInjection

✅ Swagger para documentação da API

✅ Testes unitários com xUnit (pelo menos para factories e geradores)

✅ Logging com Serilog ou NLog

✅ Padrão RESTful
