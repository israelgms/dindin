<template>
  <div>
    <div class="conteiner">
    <table class="tabela-painel">
      <thead class="tabela__Cabecalho">
        <th id class="cabecalho c1" >Cursos</th>
        <th class="cabecalho" colspan="2">Ações</th>
      </thead>
      <tbody>
        <tr>
          <td class="dadoTabela-curso c1">Investimento Para iniciantes</td>
          <td class="dadoTabela-botton">
            <button class="botton-editar">Editar</button>
          </td>
          <td class="dadoTabela-botton">
            <button class="botton-excluir">Excluir</button>
          </td>
        </tr>
      </tbody>
    </table>
    </div>
  </div>
</template>
<script>
export default {
  nome: "PainelAcoes",
};
</script>
<style scoped>
.conteiner{
  overflow-x: auto;
}
.tabela-painel {
  margin-top: 107px;
  margin-left: 82px;
  width: 812px;
  /*
  position: absolute;
  width: 63px;
  height: 28px;
  left: 106px;
  top: 405px;
  */
}
.tabela__Cabecalho {
  background-color: #ebebeb;
}
.cabecalho {
  color: #000000;
  font-size: 24px;
  font-style: normal;
  font-family: Ubuntu;
  text-align: left;
}
.c1{
max-width: 100px;
background: #f8c23a;
}
.botton-editar {
  background-color: #f8c23a;
  width: 87px;
  height: 22px;
  font-family: Ubuntu;
  font-style: normal;
  font-weight: normal;
  font-size: 15px;
  line-height: 17px;
  margin-bottom: 11px;
  margin-top: 11px;
}
.botton-excluir {
  background-color: #f8513a;
  width: 87px;
  height: 22px;
  font-family: Ubuntu;
  font-style: normal;
  font-weight: normal;
  font-size: 15px;
  line-height: 17px;
  margin-bottom: 11px;
  margin-top: 11px;
}
.dadoTabela-botton {
  text-align:left;
  margin: 12px;
  width: 20px;
}

</style>
