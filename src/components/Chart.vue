<script>
import { Bar } from 'vue-chartjs'
// import the component - chart you need

export default Bar.extend({
  mounted () {
    // Overwriting base render method with actual data.
    this.renderChart({
      labels: ["Com Renda","Sem Renda"],
      datasets: [
        {
          label: "Renda",
          backgroundColor: '#3c8dbc',
          data: ["1000","750"]
        }
      ]
    },)
  }
})
</script>


