<?php

/* form/fields.html.twig */
class __TwigTemplate_0f7f05c6d8839a201b96c70daec6b0e969d5c2f45c2ababd56f60ba7f7df88e2 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d4d8da01e6ef357b08a3db074ff5dc5679de9ec28168bb0058d8c1180444d985 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d4d8da01e6ef357b08a3db074ff5dc5679de9ec28168bb0058d8c1180444d985->enter($__internal_d4d8da01e6ef357b08a3db074ff5dc5679de9ec28168bb0058d8c1180444d985_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_d4d8da01e6ef357b08a3db074ff5dc5679de9ec28168bb0058d8c1180444d985->leave($__internal_d4d8da01e6ef357b08a3db074ff5dc5679de9ec28168bb0058d8c1180444d985_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_11a5a496c5792af4a481c30dd53bb7501ade9a7f257e276e9b5d377a134aa80b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_11a5a496c5792af4a481c30dd53bb7501ade9a7f257e276e9b5d377a134aa80b->enter($__internal_11a5a496c5792af4a481c30dd53bb7501ade9a7f257e276e9b5d377a134aa80b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_11a5a496c5792af4a481c30dd53bb7501ade9a7f257e276e9b5d377a134aa80b->leave($__internal_11a5a496c5792af4a481c30dd53bb7501ade9a7f257e276e9b5d377a134aa80b_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
