import { Meta, Story } from "@storybook/react";
import { Second, SecondProps } from "./second";

export default {
  title: "Components/Second",
  component: Second
} as Meta;

const Template: Story<SecondProps> = props => <Second {...props} />;

export const Default = Template.bind({});

Default.args = {};