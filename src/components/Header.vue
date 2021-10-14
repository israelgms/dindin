<template>
  <div>
    <h1 class="title">{{title}}</h1>
    <p class="subtitle">Educação financeira é tudo de bom</p>
  </div>
</template>

<script>
export default {
  name: "Header",

  props:{
      title: "",
  }
};
</script>