# FiscalNet
## Biblioteca de cálculos fiscais

![Badge](https://img.shields.io/static/v1?label=csharp&message=language&color=blue&style=for-the-badge&logo=csharp)
![Badge](https://img.shields.io/static/v1?label=.net6&message=framework&color=blue&style=for-the-badge&logo=.net)

[![Nuget count](https://img.shields.io/nuget/v/FiscalNet)](https://www.nuget.org/packages/FiscalNet/2022.6.1)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

## Sobre o projeto 
  Este projeto é uma biblioteca que auxilia na implementação de cálculos tributários para emissão de documentos fiscais eletrônicos no Brasil. Cálculo de ICMS, ICMS-ST, IPI, PIS e COFINS.

Este projeto é mantido utilizando a linguagem CSharp com .Net Standard e tem o projeto de teste validando os resultados. 

## Recursos

- ICMS
- ICMS-ST
- IPI
- PIS
- COFINS

Recomendamos que os cálculos sejam validados pelo contador da empresa que utilizará a biblioteca.

## Utilização
```sh
Icms00 icms00 = new Icms00(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                                       valorIpi, valorDesconto, aliquotaIcmsProprio);

decimal vBC = icms00.BaseIcmsProprio();

decimal vICMS = icms00.ValorIcmsProprio();
```

## Suporte
<img src="https://www.sacfiscal.com.br/biosac64.png">
Nossa empresa é especializada em suporte técnico e tributário para software houses.
Acesse: https://www.sacfiscal.com.br

| Tecnologias | Frameworks |
| ------ | ------ |
| C# | ZeusDFe <https://github.com/ZeusAutomacao/DFe.NET> UniNFe <https://github.com/Unimake/DFe> OpenAC <https://github.com/OpenAC-Net> |
| Delphi | ACBr <https://projetoacbr.com.br/> |
| Lazarus | ACBr <https://projetoacbr.com.br/> |
| PHP | SPEDNFe <https://github.com/nfephp-org/sped-nfe> |


## Curso de Arquitetura Fiscal em Software
ARQUITETURA FISCAL EM SOFTWARE <https://www.arquiteturafiscal.com.br>
<br>O mais completo treinamento de tributação e regras fiscais para programadores e software houses

## Licença

GPL
