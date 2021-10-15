<template>
  <div id="app">
    <NavBar />
    <router-view/>
    <Footer />
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'
import Footer from './components/Footer.vue'

export default {
  name: "App",
  
  components: {
    NavBar, 
    Footer,
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Ubuntu:wght@300;400;500;700&display=swap');
* {
  padding: 0;
  margin: 0;
  font-family: 'Ubuntu', sans-serif;
  text-decoration: none;
  list-style: none;
  border: none;
}

</style>
