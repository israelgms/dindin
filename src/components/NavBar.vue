<template>
  <div id="nav">
    <router-link to="/">
      <div class="logo">
        <img src="../assets/dindin-logo.png" alt="dindin logo" />
        <h2>dindin</h2>
      </div>
    </router-link>
    <div class="menu">
      <router-link to="/">CURSOS</router-link>
      <router-link to="/painel">PAINEL ADMINISTRATIVO</router-link>
    </div>
  </div>
</template>

<script>
export default {
  name: "NavBar",
};
</script>

<style scoped>
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
  cursor: pointer;
}

h2 {
  margin-top: 33px;
  font-size: 56px;
  font-weight: 500;
  color: #ffffff;
}

@media screen and (max-width: 770px) {
  #nav, .menu {
    background-color: #2e948a;
    flex-direction: column;
  }
  .menu {
    margin-top: 0;
    text-align: center;
    font-size: 20px;
    font-weight: 700;
  }
  .menu a {
    color: #FFFFFF;
    display: block;
    margin-bottom: 10px;
  }
}
</style>

