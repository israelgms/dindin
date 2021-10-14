<template>
  <!-- INICIO ID nav -->
  <div id="nav">
    <div class="logo">
        <img src="../assets/dindin-logo.png" alt="dindin logo" />
        <h2>dindin</h2>
    </div>
    <!-- INICIO CLASS menu -->
    <div class="menu">
      <router-link to="/">CURSOS</router-link>
      <router-link to="/painel">PAINEL ADMINISTRATIVO</router-link>
    </div>
    <!-- FIM CLASS menu -->
  </div>
  <!-- FIM ID nav -->
</template>

<style>
#nav {
  background-color: #2e948a;
  height: 117px;
  display: flex;
  color: #ffffff;
  justify-content: space-between;
}

.menu {
  margin-top: 47px;
  font-size: 20px;
  font-weight: 700;
}

.menu a {
  margin-right: 40px;
  color: #ffffff;
}

.logo img {
  height: 71px;
  margin: 20px 11px 26px 82px;
}

.logo {
  display: flex;
}

h2 {
  margin-top: 33px;
  font-size: 56px;
  font-weight: 500;
}
</style>

<script>
export default {
  name: "NavBar",
};
</script>