<template>
  <div class="home">
    <div class="mdl-layout mdl-js-layout mdl-layout--fixed-header">
      <header class="home-header mdl-layout__header">
        <div class="mdl-layout__header-row">
          <!-- Title -->
          <span class="home-header-title mdl-layout-title">{{ title }}</span>
          <!-- Add spacer, to align navigation to the right -->
          <div class="mdl-layout-spacer"></div>
          <!-- Navigation. We hide it in small screens. -->
          <nav class="mdl-navigation mdl-layout--large-screen-only">
            <a class="mdl-navigation__link" href="">Cadastro</a>
            <a class="mdl-navigation__link" href="">Login</a>
          </nav>
        </div>
      </header>
      <div class="home-drawer mdl-layout__drawer">
        <span class="mdl-layout-title">{{ title }}</span>
        <nav class="mdl-navigation">
          <a class="mdl-navigation__link" href="">Cadastro</a>
          <a class="mdl-navigation__link" href="">Login</a>
        </nav>
      </div>
      <main class="mdl-layout__content">
        <div class="home-main-section mdl-typography--text-center">
          <div class="logo-font home-slogan">Abre Aqui</div>
          <div class="logo-font home-sub-slogan">Onde seu negócio dá certo!</div>
          <div class="input-box-container">
            <div class="input-box">
              <div class="input-container mdl-card mdl-shadow--4dp">
                <i class="input-icon material-icons">location_on</i>
                <form action="#">
                  <div class="input-text mdl-textfield mdl-js-textfield">
                    <input class="mdl-textfield__input" v-model="choosenCity" placeholder="Digite aqui sua localização" type="text" id="location-input">
                    <label class="mdl-textfield__label" for="location-input" ></label>
                  </div>
                </form>
                <button @click="getCounty()" class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored">
                  Buscar
                </button>
              </div>
            </div>
          </div>
        </div>
          <div class="best-city-section">
            <card :title="'Rio de janeiro'" :secondaryText="'bla bla bal bal blablablalba'"></card>
          </div>
      </main>
    </div>
  </div>
</template>



<script>  
import SuggestionBox from '@/components/SuggestionBox'
import InputBox from '@/components/InputBox'
import Card from '@/components/Card'
import CommitChart from '@/components/Chart'
import PlaceInput from 'vue-google-maps'
import axios from 'axios'


export default {
  name: 'home',
  components: {

    SuggestionBox,
    CommitChart,
    InputBox,
    Card
  },
  data () {
    return {
      title: 'Abre Aqui',
      choosenCity: null,
      countyId: null,
      choosenCityData: null,
      errors: []
    }
  },
  methods: {
    getCounty () {
      if(this.choosenCity === 'Rio de Janeiro')
        this.countyId = 3304557
      if(this.choosenCity === 'São Paulo')
        this.countyId = 3550308
      if(this.choosenCity === 'Belo Horizonte')
        this.countyId = 3106200
      if(this.choosenCity === 'Brasília')
        this.countyId = 5300108
      axios.get('http://api.sidra.ibge.gov.br/values/t/1552/n6/' + this.countyId + '/c2/all')
      .then(response => {
        this.choosenCityData = response.data
      })
      console.log(choosenCityData)
    }
  }
}
</script>

<style lang="scss" scoped>

.home-header {
  overflow: visible;
}

.home-header .material-icons {
  color: #fff !important;
}

.home-header .mdl-layout__drawer-button {
  background: transparent;
  color: #fff;
}

.home-header .mdl-navigation__link {
  color: #fff;
  font-weight: 700;
  font-size: 14px;
}

  .home-header-title {
    color: #fff;
    font-weight: 700;
    font-size: 24px;
  }

.logo-font {
  font-family: 'Roboto', 'Helvetica', 'Arial', sans-serif;
  line-height: 1;
  color: #FFF;
  font-weight: 500;
}

.home-slogan {
  color: #ffffff;
  font-size: 80px;
  padding-top: 80px;
}

.home-sub-slogan {
  color: #ffffff;
  font-size: 41px;
  padding-top: 24px;
}

.home-main-section {
  position: relative;
  height: 450px;
  width: auto;
  background-color: #f3f3f3;
  background: url('../assets/ipanema-up.png') center 30% no-repeat;
  background-size: cover;
  
}

.input-box-container {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  align-content: center;
  align-items: center;
  justify-content: space-around;
  padding: 2em;
  margin-top: 2em;
}

    .input-box {
      padding: 2em;
    }

    .input-container.mdl-card {
      display: flex;
      flex-direction: row;
      width: 620px;
      min-height: 64px;
      height: 64px;
      align-items: center;
      justify-content: space-around;
    }

    .input-icon {
      padding-right: 1em;
      padding-left: 1em;
    }

    .input-text {
      padding-right: 2em;
    }

</style>
