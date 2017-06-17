<template>
<!-- Wide card with share menu button -->
<div class="demo-card-wide mdl-card mdl-shadow--2dp">
  <div class="mdl-card__title">
    <h2 class="mdl-card__title-text">{{ title }}</h2>
  </div>
  <div class="mdl-card__supporting-text">
    {{ secondaryText }}
  </div>
</div>
</template>

<script>
export default {
  name: 'card',
  props: {
    title: {
      type: String
    },
    secondaryText: {
      type: String
    }
  },
  data () {
    return {
      msg: 'card'
    }
  },
  methods: {
    getCounty (countyId) {
      axios.get('http://api.sidra.ibge.gov.br/values/t/1552/n6/' + countyId + '/c2/all')
      .then(response => {
        console.log(response.data)
        this.posts = response.data
      })
      .catch(e => {
        this.errors.push(e)
      })
    }
  }
}

</script>

<style scoped>
.demo-card-wide.mdl-card {
  width: 80%;
  height: auto;
  margin: 50px;
  display: inline-block;
}
.demo-card-wide > .mdl-card__title {
  color: #fff;
  height: 80px;
}
.demo-card-wide > .mdl-card__menu {
  color: #fff;
}
.mdl-card__title-text{
  color: #000;
}
</style>