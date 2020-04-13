// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import router from './router' 
import Antd from 'ant-design-vue';
import { DatePicker } from 'ant-design-vue';
import Button from 'ant-design-vue/lib/button';
import 'ant-design-vue/dist/antd.css';
import App from './App'

Vue.component(Button.name, Button);
Vue.use(Antd);
Vue.use(DatePicker);
Vue.config.productionTip = false
import 'ant-design-vue/dist/antd.css'; // or 'ant-design-vue/dist/antd.less'
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
