<template>
<!-- Wide card with share menu button -->
<div class="demo-card-wide mdl-card mdl-shadow--2dp">

  <div class="mdl-card__title">
    <h2 class="mdl-card__title-text">{{ title }}</h2>
  </div>
  <div class="container">
        <div>
          <h5>Total da população por sexo</h5>
          <pieChart></pieChart>
        </div>
        <div>
          <h5>Rendimento médio</h5>

          <commitChart></commitChart>
        </div>
        <div>
          <h5>Demandas por categorias de negócio</h5>

          <PieChartDemandas></PieChartDemandas>
        </div>
      </div>

  <suggestion-list></suggestion-list>
</div>
</template>

<script>
import CommitChart from '@/components/Chart'
import PieChart from '@/components/PieChart'
import PieChartDemandas from '@/components/PieChartDemandas'
import SuggestionList from '@/components/SuggestionList'


export default {
  name: 'card',
  components: {
    PieChart,
    CommitChart,
    PieChartDemandas,
    SuggestionList
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
  width: 25%;
margin-left: 10%;
}
</style>