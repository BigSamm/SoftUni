<?php

/* :anime:index.html.twig */
class __TwigTemplate_bdcc65a75b6902c7c24238dd202747880b0348fd81aff4ab0f9c332794338315 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":anime:index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_5f1a38d01ac33cede8e874ced5e8957b503c5f3774eb08a9fefd97b0a62a2587 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5f1a38d01ac33cede8e874ced5e8957b503c5f3774eb08a9fefd97b0a62a2587->enter($__internal_5f1a38d01ac33cede8e874ced5e8957b503c5f3774eb08a9fefd97b0a62a2587_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":anime:index.html.twig"));

        $__internal_b178503fe20080721965324051c9439760b79c046bd629645a4ee510a2ed61c3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b178503fe20080721965324051c9439760b79c046bd629645a4ee510a2ed61c3->enter($__internal_b178503fe20080721965324051c9439760b79c046bd629645a4ee510a2ed61c3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":anime:index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_5f1a38d01ac33cede8e874ced5e8957b503c5f3774eb08a9fefd97b0a62a2587->leave($__internal_5f1a38d01ac33cede8e874ced5e8957b503c5f3774eb08a9fefd97b0a62a2587_prof);

        
        $__internal_b178503fe20080721965324051c9439760b79c046bd629645a4ee510a2ed61c3->leave($__internal_b178503fe20080721965324051c9439760b79c046bd629645a4ee510a2ed61c3_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_c6a569e9419314a9ca2d4dd3697baa0c62d90494ccd36bb70d98abaa5b455cbc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c6a569e9419314a9ca2d4dd3697baa0c62d90494ccd36bb70d98abaa5b455cbc->enter($__internal_c6a569e9419314a9ca2d4dd3697baa0c62d90494ccd36bb70d98abaa5b455cbc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_d8557f076bd31aade71d94193dcb58b9fa0a1924caa13ddb760889d4bccb3f4d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d8557f076bd31aade71d94193dcb58b9fa0a1924caa13ddb760889d4bccb3f4d->enter($__internal_d8557f076bd31aade71d94193dcb58b9fa0a1924caa13ddb760889d4bccb3f4d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>Anime List</h1>

<section>
    <div>
        <table>
            <tr>
                <th>Rating</th>
                <th>Name</th>
                <th>Description</th>
                <th>Watched</th>
                <th>Actions</th>
            </tr>
            ";
        // line 16
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["animes"] ?? $this->getContext($context, "animes")));
        foreach ($context['_seq'] as $context["_key"] => $context["anime"]) {
            // line 17
            echo "            <tr>
                <td>";
            // line 18
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "rating", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 19
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 20
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "description", array()), "html", null, true);
            echo "</td>
                <td>
                    <input class=\"checkbox\" type=\"checkbox\" value=\"";
            // line 22
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "watched", array()), "html", null, true);
            echo "\" onclick=\"preventEvent(event)\" name=\"";
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "\" />
                    <label for=\"";
            // line 23
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "name", array()), "html", null, true);
            echo "\"></label>
                </td>
                <td>
                    <button class=\"delete\" onclick=\"location.href='/delete/";
            // line 26
            echo twig_escape_filter($this->env, $this->getAttribute($context["anime"], "id", array()), "html", null, true);
            echo "'\">Delete</button>
                </td>
            </tr>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['anime'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 30
        echo "        </table>
    </div>
</section>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">+</button>
</div>

<script>
    function preventEvent(ev) {
        ev.preventDefault();
    }
    (function checkBox() {
        let checkboxes = document.getElementsByClassName(\"checkbox\");

        for(let i = 0; i < checkboxes.length; i++) {
            if(checkboxes[i].value === \"watched\") {
                checkboxes[i].checked = true;
            }
        }
    })();
</script>
";
        
        $__internal_d8557f076bd31aade71d94193dcb58b9fa0a1924caa13ddb760889d4bccb3f4d->leave($__internal_d8557f076bd31aade71d94193dcb58b9fa0a1924caa13ddb760889d4bccb3f4d_prof);

        
        $__internal_c6a569e9419314a9ca2d4dd3697baa0c62d90494ccd36bb70d98abaa5b455cbc->leave($__internal_c6a569e9419314a9ca2d4dd3697baa0c62d90494ccd36bb70d98abaa5b455cbc_prof);

    }

    public function getTemplateName()
    {
        return ":anime:index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  105 => 30,  95 => 26,  89 => 23,  83 => 22,  78 => 20,  74 => 19,  70 => 18,  67 => 17,  63 => 16,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>Anime List</h1>

<section>
    <div>
        <table>
            <tr>
                <th>Rating</th>
                <th>Name</th>
                <th>Description</th>
                <th>Watched</th>
                <th>Actions</th>
            </tr>
            {% for anime in animes %}
            <tr>
                <td>{{ anime.rating }}</td>
                <td>{{ anime.name }}</td>
                <td>{{ anime.description }}</td>
                <td>
                    <input class=\"checkbox\" type=\"checkbox\" value=\"{{ anime.watched }}\" onclick=\"preventEvent(event)\" name=\"{{ anime.name }}\" />
                    <label for=\"{{ anime.name }}\"></label>
                </td>
                <td>
                    <button class=\"delete\" onclick=\"location.href='/delete/{{ anime.id }}'\">Delete</button>
                </td>
            </tr>
            {% endfor %}
        </table>
    </div>
</section>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">+</button>
</div>

<script>
    function preventEvent(ev) {
        ev.preventDefault();
    }
    (function checkBox() {
        let checkboxes = document.getElementsByClassName(\"checkbox\");

        for(let i = 0; i < checkboxes.length; i++) {
            if(checkboxes[i].value === \"watched\") {
                checkboxes[i].checked = true;
            }
        }
    })();
</script>
{% endblock %}", ":anime:index.html.twig", "D:\\PHP Solution\\app/Resources\\views/anime/index.html.twig");
    }
}
