<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_2599054065e1e61fcf9f1092ce80d126a0acc76717077db70309bd5b9d4c87f1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2599054065e1e61fcf9f1092ce80d126a0acc76717077db70309bd5b9d4c87f1->enter($__internal_2599054065e1e61fcf9f1092ce80d126a0acc76717077db70309bd5b9d4c87f1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_2d8b570a260a45d7615b7ee48b62f74b15496dd60d9ec0012e4aad8b51f97d65 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2d8b570a260a45d7615b7ee48b62f74b15496dd60d9ec0012e4aad8b51f97d65->enter($__internal_2d8b570a260a45d7615b7ee48b62f74b15496dd60d9ec0012e4aad8b51f97d65_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_2599054065e1e61fcf9f1092ce80d126a0acc76717077db70309bd5b9d4c87f1->leave($__internal_2599054065e1e61fcf9f1092ce80d126a0acc76717077db70309bd5b9d4c87f1_prof);

        
        $__internal_2d8b570a260a45d7615b7ee48b62f74b15496dd60d9ec0012e4aad8b51f97d65->leave($__internal_2d8b570a260a45d7615b7ee48b62f74b15496dd60d9ec0012e4aad8b51f97d65_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_c7a23791d958d656c51b83b4b74367f17ad91f2f4ceeb1b0769ac313c69eabd2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c7a23791d958d656c51b83b4b74367f17ad91f2f4ceeb1b0769ac313c69eabd2->enter($__internal_c7a23791d958d656c51b83b4b74367f17ad91f2f4ceeb1b0769ac313c69eabd2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_a547f034505e2cb7fc88f2fc6ffb408958dce7515048a3d862f426319ec45789 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a547f034505e2cb7fc88f2fc6ffb408958dce7515048a3d862f426319ec45789->enter($__internal_a547f034505e2cb7fc88f2fc6ffb408958dce7515048a3d862f426319ec45789_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_a547f034505e2cb7fc88f2fc6ffb408958dce7515048a3d862f426319ec45789->leave($__internal_a547f034505e2cb7fc88f2fc6ffb408958dce7515048a3d862f426319ec45789_prof);

        
        $__internal_c7a23791d958d656c51b83b4b74367f17ad91f2f4ceeb1b0769ac313c69eabd2->leave($__internal_c7a23791d958d656c51b83b4b74367f17ad91f2f4ceeb1b0769ac313c69eabd2_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_116300268ec356fdb94020153b6e900986ccea6698fd068427b42b38a2fc37ee = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_116300268ec356fdb94020153b6e900986ccea6698fd068427b42b38a2fc37ee->enter($__internal_116300268ec356fdb94020153b6e900986ccea6698fd068427b42b38a2fc37ee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_87bfb4c3db8209779f5e2d1066585f8d635f5a9406494c2048fb0c409e582223 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_87bfb4c3db8209779f5e2d1066585f8d635f5a9406494c2048fb0c409e582223->enter($__internal_87bfb4c3db8209779f5e2d1066585f8d635f5a9406494c2048fb0c409e582223_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_87bfb4c3db8209779f5e2d1066585f8d635f5a9406494c2048fb0c409e582223->leave($__internal_87bfb4c3db8209779f5e2d1066585f8d635f5a9406494c2048fb0c409e582223_prof);

        
        $__internal_116300268ec356fdb94020153b6e900986ccea6698fd068427b42b38a2fc37ee->leave($__internal_116300268ec356fdb94020153b6e900986ccea6698fd068427b42b38a2fc37ee_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_58dbaaeb0fa0c6d1b9d833b116e83de02485fd3d2997f76363ce1e43a7405ab2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_58dbaaeb0fa0c6d1b9d833b116e83de02485fd3d2997f76363ce1e43a7405ab2->enter($__internal_58dbaaeb0fa0c6d1b9d833b116e83de02485fd3d2997f76363ce1e43a7405ab2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_72081279f080a55ebfa6119092c85fc6e8ae393165591cfb3ba69a16f3ec82b8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_72081279f080a55ebfa6119092c85fc6e8ae393165591cfb3ba69a16f3ec82b8->enter($__internal_72081279f080a55ebfa6119092c85fc6e8ae393165591cfb3ba69a16f3ec82b8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_72081279f080a55ebfa6119092c85fc6e8ae393165591cfb3ba69a16f3ec82b8->leave($__internal_72081279f080a55ebfa6119092c85fc6e8ae393165591cfb3ba69a16f3ec82b8_prof);

        
        $__internal_58dbaaeb0fa0c6d1b9d833b116e83de02485fd3d2997f76363ce1e43a7405ab2->leave($__internal_58dbaaeb0fa0c6d1b9d833b116e83de02485fd3d2997f76363ce1e43a7405ab2_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "D:\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
