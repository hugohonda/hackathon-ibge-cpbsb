<template>
<!-- Wide card with share menu button -->
<div class="demo-card-wide mdl-card mdl-shadow--2dp">

  <div class="mdl-card__title">
    <h2 class="mdl-card__title-text">{{ title }}</h2>
  </div>
  <div class="container">
        <commitChart></commitChart>
        <pieChart></pieChart>
      </div>

  <div class="mdl-card__supporting-text">
    {{ secondaryText }}
  </div>
</div>
</template>

<script>
import CommitChart from '@/components/Chart'
import PieChart from '@/components/PieChart'

export default {
  name: 'card',
  components: {
    PieChart,
    CommitChart
  },
  props: {
    title: {
      type: String
    },
    secondaryText: {
      type: String
    },
    buttonText: {
      type: String
    }
  },
  data () {
    return {
      msg: 'card'
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
.container{
  display: flex;
  flex-direction: row;
  width: 20%;
}
</style>