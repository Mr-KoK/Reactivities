import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";
import { Header, List, Icon } from "semantic-ui-react";
import axios from "axios";

class App extends Component {
  state = {
    values: []
  };
  componentDidMount() {
    axios.get("http://localhost:5000/WeatherForecast").then(Response => {
      this.setState({
        values: Response.data
      });
    });
  }
  render() {
    return (
      <div>
        <Header as="h2">
          <Icon name="users" />
          <Header.Content>Reactivities</Header.Content>
        </Header>
        <List>
          {this.state.values.map((value: any) => (
            <List.Item key={value.id}>{value.name}</List.Item>
          ))}
        </List>
        <ul></ul>
      </div>
    );
  }
}
export default App;
