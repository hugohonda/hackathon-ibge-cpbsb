<script>
import { Pie } from 'vue-chartjs'
// import the component - chart you need

export default Pie.extend({
  mounted () {
    // Overwriting base render method with actual data.
    this.renderChart({
      labels: ["Comercio","Construção","Alimentos"],
      datasets: [
        {
          label: "Demandas",
          data: ["1","1","1"],
          backgroundColor: [
                    "#FF6384",
                    "#36A2EB",
                    "#FFCE56"
                ]
        }
      ]
      
    })
  }
})
</script>


